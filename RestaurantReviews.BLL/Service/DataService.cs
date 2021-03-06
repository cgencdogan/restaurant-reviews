﻿using RestaurantReviews.BLL.Managers;
using RestaurantReviews.DAL.Context;
using RestaurantReviews.DAL.Repositories.UnitOfWork;
using RestaurantReviews.Models.Contracts;
using System;

namespace RestaurantReviews.BLL.Service {
    public class DataService {
        private AppDbContext context;
        private IUnitOfWork _unitOfWork;
        private ReviewManager _reviewManager;

        public DataService() {
            context = new AppDbContext();
        }

        public IUnitOfWork Uow {
            get {
                if (_unitOfWork == null)
                    _unitOfWork = new UnitOfWork(context);
                return _unitOfWork;
            }
        }

        public ReviewManager ReviewManager {
            get {
                if (_reviewManager == null)
                    _reviewManager = new ReviewManager();
                return _reviewManager;
            }
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }
    }
}
