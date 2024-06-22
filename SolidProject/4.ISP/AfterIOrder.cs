using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public interface I_IOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrData();

        void CalculateTOTal();
        void GenerateFrimAtEmail();
        void PrintLable();
        void SendConfirmAtEmail();
    }
    public interface IOrderPriority
    {
        void CalculateTOTal();
    }

    public interface IInvoiseJGenerate
    {
            void GenerateFrimAtEmail();
    }
    public interface IEmailSender
    {
        void SendConfirmAtEmail();
    }
    public class OnlineOrder : I_IOrder, IOrderPriority, IInvoiseJGenerate, IEmailSender
    {
        //
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

        public void SendConfirmAtEmail()
        {
            
        }

        public void UpdateOrData()
        {
            
        }
    }

    public class IInStoreOrder : I_IOrder, IOrderPriority, IEmailSender
    {
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

        public void SendConfirmAtEmail()
        {
        }

        public void UpdateOrData()
        {
        }
    }
}

