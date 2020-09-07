﻿using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.RoomsConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class OperationRoom : Entity<int>
    {
        internal OperationRoom(int roomNumber)
        {
            this.Validate(roomNumber);

            this.RoomNumber = roomNumber;
        }

        public int RoomNumber { get; private set; }

        private void Validate(int roomNumber)
           => Guard.AgainstOutOfRange<InvalidRoomException>(
               roomNumber,
               MinRoomNumber,
               MaxRoomNumber,
               nameof(this.RoomNumber));
    }
}
