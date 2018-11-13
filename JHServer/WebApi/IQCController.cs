using JHServer.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace JHServer.WebApi
{

    public class IQCController : ApiController
    {

        private DBModel db = new DBModel();

        bool TestWithReflection(dynamic d, string name)
        {
            Type type = d.GetType();

            return type.GetProperties().Any(p => p.Name.Equals(name));
        }

        public dynamic JarrayToDynamic(JArray ary)
        {
            dynamic formdata = new ExpandoObject();
            var dic = (IDictionary<string, object>)formdata;
            foreach (JObject item in ary)
            {
                //string name = item.name.ToString();
                //formdata.add()
                dic.Add(item.GetValue("name").ToString(), item.GetValue("value").ToString());
            }
            return dic;
        }

        //查询检验数据
        [Route("api/IQC/QueryIQC")]
        [HttpPost]
        public IHttpActionResult QueryIQC(dynamic para)
        {
            using (var context = new DBModel())
            {
                var iqcdetailresultlog = new tiqcdetailresultlog
                {
                    id = 1,
                    lot = "a",
                    paraid = "a",
                    result = "a",
                    no = 2
                };
                context.tiqcdetailresultlogs.Add(iqcdetailresultlog);
                context.tiqcdetailresultlogs.Add(iqcdetailresultlog);
                context.SaveChanges();

                return null;

                //dynamic where clause
                var query141 = context.tiqclogs.AsQueryable();

                //var con = new EntityConnection("name=SchoolDBEntities");
                //linq
                var data = context.tiqclogs.Join(context.tiqcdetaillogs, a => a.id, g => g.id, (a, g) => new { a.incomingno, a.incomingqty, a.inspectiontime, a.length, a.materialtype, a.pinmin, a.result, a.supplycompany, a.thinkness, a.width, a.createuser, g.lot });
                var resdata = data;
                if (!string.IsNullOrEmpty(para.bt.ToString()) && !string.IsNullOrEmpty(para.et.ToString()))
                {
                    DateTime bt = (DateTime)para.bt;
                    DateTime et = (DateTime)para.et;
                    resdata = data.Where(c => c.inspectiontime >= bt && c.inspectiontime <= et);
                }

                if (!string.IsNullOrEmpty(para.incomingno.ToString())) { string incomingno = para.incomingno.ToString(); resdata = resdata.Where(c => c.incomingno == incomingno); }
                if (!string.IsNullOrEmpty(para.supplycompany.ToString())) { string supplycompany = (string)para.supplycompany; resdata = resdata.Where(c => c.supplycompany == supplycompany); }
                if (!string.IsNullOrEmpty((string)para.materialtype)) { string materialtype = (string)para.materialtype; resdata = resdata.Where(c => c.materialtype == materialtype); }
                if (!string.IsNullOrEmpty(para.result.ToString())) { bool result = (Int16)para.result == 1 ? true : false; resdata = resdata.Where(c => c.result == result); }
                if (!string.IsNullOrEmpty(para.lot.ToString())) { string lot = (string)para.result; resdata = resdata.Where(c => c.lot == lot); }
                if (!string.IsNullOrEmpty(para.pinmin.ToString())) { string pinmin = (string)para.pinmin; resdata = resdata.Where(c => c.pinmin == pinmin); }

                var resfinal = resdata.Select(a => new { a.incomingno, a.incomingqty, a.inspectiontime, a.length, a.materialtype, a.pinmin, a.result, a.supplycompany, a.thinkness, a.width }).Distinct();

                var json = Json(resfinal.ToList());

                return json;
            }
        }

        [Route("api/IQC/SaveIQC")]
        //[ActionName("SaveIQC")]
        [HttpPost]
        public IHttpActionResult SaveIQC(dynamic para)
        {
            //处理submaindata
            //dynamic[] submainAry = new List<dynamic>().ToArray();
            List<dynamic> submainList = new List<dynamic>();
            for (int i = 0; i < para.subform.Count; i++)
            {
                submainList.Add(JarrayToDynamic(para.subform[i]));
            }
            //处理mainformdata
            dynamic mainformdata = JarrayToDynamic(para.mainform);

            //var d = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(mainformdata);
            //tiqclog iqclogdata =(tiqclog)mainformdata;

            using (var context = new DBModel())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    //try
                    //{
                        //insert mianformdata
                        var iqclog = new tiqclog
                        {
                            incomingno = (string)mainformdata.txtIncomingNo,
                            inspectiontime = Convert.ToDateTime(mainformdata.txtInspectionTime),
                            supplycompany = (string)mainformdata.ddlSupply,
                            materialtype = (string)mainformdata.ddlMaterialType,
                            pinmin = (string)mainformdata.txtPinmin,
                            thinkness = Convert.ToInt32(mainformdata.txtThinkness),
                            width = Convert.ToInt32(mainformdata.txtWidth),
                            length = Convert.ToInt32(mainformdata.txtLength),
                            incomingqty = Convert.ToInt32(mainformdata.txtDeliveryQty),
                            createuser = para.userid.ToString(),
                            result = Convert.ToInt16(para.result) == 1 ? true : false
                        };
                        context.tiqclogs.Add(iqclog);
                        context.SaveChanges();

                        long detailtableid = iqclog.id;
                        //insert subformdata
                        foreach (var item in submainList)
                        {
                            //var iqcdetaillog = new tiqcdetaillog();
                            foreach (KeyValuePair<string, object> kvp in item)
                            {

                                long tempid;
                                string templot;
                                string tempsublot;
                                int tempno;
                                string result;

                                tempid = detailtableid;
                                templot = (string)mainformdata.txtIncomingNo;
                                //tempsublot = kvp.Value.ToString();
                                tempno = Convert.ToInt32(Regex.Replace(kvp.Key.ToString(), @"[^\d.\d]", ""));
                                var detailresult = db.tiqcdetailresultlogs.SingleOrDefault(e => e.id == tempid && e.lot == templot && e.no == tempno);
                                var a = kvp;
                                if (kvp.Key.ToString().Contains("Result"))
                                {
                                    //var resultresult = db.tiqcdetailresultlogs.SingleOrDefault(e => e.id == tempid && e.lot == templot && e.no == tempno);
                                    //if (detailresult != null)
                                    //{
                                    //    detailresult.result = kvp.Value.ToString();
                                    //}
                                    //else
                                    {
                                        var iqcdetailresultlog = new tiqcdetailresultlog
                                        {
                                            id = tempid,
                                            lot = templot,
                                            paraid = kvp.Key.ToString(),
                                            result = kvp.Value.ToString(),
                                            no = tempno
                                        };
                                        context.tiqcdetailresultlogs.Add(iqcdetailresultlog);
                                    }
                                    //context.SaveChanges();
                                }
                                //保存抽检子批次号
                                else if (kvp.Key.ToString().Contains("txtLot"))
                                {    
                                    ////===================批次已经记录============================
                                    //if (detailresult != null)
                                    //{
                                    //    detailresult.sublot = tempsublot;
                                    //}
                                    //else //===============批次还没记录============================
                                    //{
                                    //    var iqcdetailresultlog = new tiqcdetailresultlog
                                    //    {
                                    //        id = tempid,
                                    //        lot = templot,
                                    //        //paraid = kvp.Key.ToString(),
                                    //        sublot = kvp.Value.ToString(),
                                    //        no = tempno
                                    //    };
                                    //    context.tiqcdetailresultlogs.Add(iqcdetailresultlog);
                                    //}
                                    //context.SaveChanges();
                                }
                                //保存检验内容
                                else
                                {
                                    var iqcdetaillog = new tiqcdetaillog
                                    {

                                        id = detailtableid,
                                        lot = (string)mainformdata.txtIncomingNo,
                                        paratype = kvp.Key.ToString(),
                                        paraid = kvp.Value.ToString(),
                                        parasubtype = Regex.Replace(kvp.Key.ToString(), @"[^\d.\d]", ""),
                                    };
                                    context.tiqcdetaillogs.Add(iqcdetaillog);
                                }
                            }
                        }
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    //}
                    //catch (Exception ex)
                    //{
                    //    dbContextTransaction.Rollback();
                    //    return Json(new { result = "fail", msg = "" });
                    //}
                }
            }
            //dynamic formdata = new ExpandoObject();
            //var dic = (IDictionary<string, object>)formdata;
            ////遍历json数组
            //foreach (var item in para)
            //{
            //   string name= item.name.ToString();
            //    //formdata.add()
            //    dic.Add(item.name.ToString(), item.value.ToString());
            //}


            //formdata.txtInspectionTime = "2018-9-23";
            //var res = para[0]["value"];

            //bool boolres= TestWithReflection(formdata, "txtInspectionTime");

            return Json(new { result = "success", msg = "" });
        }



        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}