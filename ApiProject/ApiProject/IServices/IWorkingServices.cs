﻿using ApiProject.Models;


namespace ApiProject.IServices

{
    public interface IWorkingServices
    {
        IQueryable<dynamic> getAllWorking();
        dynamic CreateWorking(Working working);
        dynamic UpdateWorking(Working working);
        IQueryable<dynamic> SearchByWorkingName(Working working);
        dynamic SearchWorkingById(Working working);
    }
}