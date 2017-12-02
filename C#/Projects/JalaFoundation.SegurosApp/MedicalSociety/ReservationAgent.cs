using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    public sealed class ReservationAgent
    {
        List<Doctor> doctorsList;
        List<Patient> patientsList;
        List<Reservation> reservationsList;

        public ReservationAgent()
        {
            doctorsList = new List<Doctor>();
            patientsList = new List<Patient>();
            reservationsList = new List<Reservation>();
        }

        public void Reserve(string pName, string dName, DateTime suggestedTime)
        {
            Patient patient = FindPatient(pName);
            Doctor doctor = FindDoctor(dName);

            if (patient != null)
            {
                if (doctor != null)
                {
                    bool hasReservation = HasReservation(patient);

                    if (!hasReservation)
                    {
                        if (IsTimeAvailable(doctor, suggestedTime))
                        {
                            reservationsList.Add(new Reservation(patient, doctor, suggestedTime));
                            Console.WriteLine("Reservation scheduled");
                        }
                        else
                        {
                            Console.WriteLine("That time is occupied");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El paciente ya tiene una reservacion");
                    }
                }
                else
                {
                    Console.WriteLine("The doctor does not exists");
                }
            }
            else
            {
                Console.WriteLine("The patient does not exists");
            }
        }

        public void AddPacient(string name, int CI)
        {
            Patient patient = new Patient(name, CI);
            patientsList.Add(patient);
        }

        public void AddDoctor(string name, int CI, TimeSpan startTime, TimeSpan endTime)
        {
            doctorsList.Add(new Doctor(name, CI, startTime, endTime));
        }

        private Patient FindPatient(string pName)
        {
            for (int i = 0; i < patientsList.Count; i++)
            {
                if (patientsList[i].name == pName)
                {
                    return patientsList[i];
                }
            }
            return null;
        }

        private Doctor FindDoctor(string dName)
        {
            for (int i = 0; i < doctorsList.Count; i++)
            {
                if (doctorsList[i].name == dName)
                {
                    return doctorsList[i];
                }
            }
            return null;
        }

        private bool HasReservation(Patient patient)
        {
            for (int i = 0; i < reservationsList.Count; i++)
            {
                if (reservationsList[i].patient == patient)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsTimeAvailable(Doctor doctor, DateTime dateTime)
        {
            for (int i = 0; i < reservationsList.Count; i++)
            {
                if (reservationsList[i].doctor == doctor && reservationsList[i].time == dateTime)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
