﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public interface BeforeIOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrData();
        void CalculateTOTal();
        void GenerateFrimAtEmail();
        void PrintLable();
    }
    public class InStoreOrder : BeforeIOrder
    {
        // Implementation of null method
        public void CalculateTOTal()
        {
           
        }

        public void CancelOrder()
        {
            
        }

        public void GenerateFrimAtEmail()
        {
            
        }

        public void PlaceOrder()
        {
            
        }

        public void PrintLable()
        {
            
        }

        public void UpdateOrData()
        {
            
        }
    }
}
