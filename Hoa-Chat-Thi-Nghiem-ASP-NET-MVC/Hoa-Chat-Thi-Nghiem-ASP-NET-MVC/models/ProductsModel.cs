using Model.entity;
using Model.service;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models
{
    public class ProductsModel
    {
        public IPagedList<Product> ListOfProducts { get; set; }
        public ProductsModel CreateModel(int id, int pageSize, int? page)
        {
            List<Product> list = null;
            if (id <= 30)
            {
                list = ProductService.findProductsByIdType(id);
            }
            else // id hoachat =40, id dungcu = 50, id thietbi = 60
            {
                id -= 40;
                list = ProductService.findProductsByIdTypeMain(id);
            }
            IPagedList<Product> data = list.ToList().ToPagedList(page ?? 1, pageSize);
            return new ProductsModel
            {
                ListOfProducts = data
            };
        }
    }
}