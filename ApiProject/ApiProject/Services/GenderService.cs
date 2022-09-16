﻿using ApiProject.IServices;
using ApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Services
{
    public class GenderService : IGenderServices
    {
        private readonly TestTek4TvContext _context;

        public GenderService(TestTek4TvContext context)
        {
            _context = context;
        }

        public IQueryable<dynamic> getAllGender()
        {
            return _context.Genders;
        }
        public dynamic CreateGender(Gender gender)
        {
            Gender rl = new Gender
            {
                GenderName = gender.GenderName,
                Status = true,
            };
            _context.Genders.Add(rl);
            _context.SaveChanges();
            return rl;
        }
        public dynamic UpdateGender(Gender gender)
        {
            var checkId = _context.Genders.FirstOrDefault(c => c.GenderId == gender.GenderId);
            if (checkId == null)
            {
                return false;
            }
            checkId.GenderName = gender.GenderName;
            _context.Genders.Update(checkId);
            _context.SaveChanges();
            return checkId;
        }

        public IQueryable<dynamic> SearchByGenderName(Gender gender)
        {
            var keyword = _context.Genders.Where(c => c.GenderName.Contains(gender.GenderName));
            return keyword.ToList().AsQueryable();
        }
        public dynamic SearchGenderById(Gender gender)
        {
            var genderById = _context.Genders.FirstOrDefault(c => c.GenderId == gender.GenderId);
            return genderById;
        }
    }
}