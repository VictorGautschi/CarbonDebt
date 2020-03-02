using System;
using AutoMapper;
using CarbonDebt.Data;
using CarbonDebt.Models;

namespace CarbonDebt.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            // Creates a map between the below classes (LeaveType & DetailsLeaveTypeViewMode) etc.
            CreateMap<LeaveType, DetailsLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }
    }
}
