using BlazorCodeFirst.Shared.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCodeFirst.Server.Data
{
    public class OrderDataAccessLayer
    {
        OrderDBContext orderDBContext = new OrderDBContext();

        #region "Order Area"
        public IEnumerable<Order> GetOrderList()
        {
            return orderDBContext.Orders.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return orderDBContext.Orders.Find(orderId);
        }

        // Add a new order
        public void AddOrder(Order order)
        {
            orderDBContext.Orders.Add(order);
            orderDBContext.SaveChanges();
        }

        // Update an order
        public void UpdateOrder(Order order)
        {
            orderDBContext.Entry(order).State = EntityState.Modified;
            orderDBContext.SaveChanges();
        }

        // Delete an order
        public void DeleteOrder(int id)
        {
            var orderInfo = orderDBContext.Orders.Find(id);
            orderDBContext.Orders.Remove(orderInfo);
            orderDBContext.SaveChanges();
        }

        #endregion

        #region "Dimension Area"
        public IEnumerable<Dimension> GetDimensionList()
        {
            return orderDBContext.Dimensions.ToList();
        }

        public Dimension GetDimensionById(int dimensionId)
        {
            return orderDBContext.Dimensions.Find(dimensionId);
        }

        // Add a new dimension
        public void AddDimension(Dimension dimension)
        {
            orderDBContext.Dimensions.Add(dimension);
            orderDBContext.SaveChanges();
        }

        // Update a dimension
        public void UpdateDimension(Dimension dimension)
        {
            orderDBContext.Entry(dimension).State = EntityState.Modified;
            orderDBContext.SaveChanges();
        }

        // Delete a state
        public void DeleteDimension(int id)
        {
            var dimension = orderDBContext.Dimensions.Find(id);
            orderDBContext.Dimensions.Remove(dimension);
            orderDBContext.SaveChanges();
        }

        #endregion

        #region "State Area"
        public IEnumerable<State> GetStateList()
        {
            return orderDBContext.States.ToList();
        }

        public State GetStateById(int stateId)
        {
            return orderDBContext.States.Find(stateId);
        }

        // Add a new state
        public void AddState(State state)
        {
            orderDBContext.States.Add(state);
            orderDBContext.SaveChanges();
        }

        // Update a state
        public void UpdateState(State state)
        {
            orderDBContext.Entry(state).State = EntityState.Modified;
            orderDBContext.SaveChanges();
        }

        // Delete a state
        public void DeleteState(int id)
        {
            var stateInfo = orderDBContext.States.Find(id);
            orderDBContext.States.Remove(stateInfo);
            orderDBContext.SaveChanges();
        }

        #endregion

        #region "Element Type Area"
        public IEnumerable<ElementType> GetElementTypes()
        {
            return orderDBContext.ElementTypes.ToList();
        }

        public ElementType GetElementTypeById(int elementTypeId)
        {
            return orderDBContext.ElementTypes.Find(elementTypeId);
        }

        // Add an element type
        public void AddElementType(ElementType element)
        {
            orderDBContext.ElementTypes.Add(element);
            orderDBContext.SaveChanges();
        }

        // Update an element type
        public void UpdateElementType(ElementType element)
        {
            orderDBContext.Entry(element).State = EntityState.Modified;
            orderDBContext.SaveChanges();
        }

        // Delete an element type
        public void DeleteElementType(int id)
        {
            var elementType = orderDBContext.ElementTypes.Find(id);
            orderDBContext.ElementTypes.Remove(elementType);
            orderDBContext.SaveChanges();
        }

        #endregion
    }
}
