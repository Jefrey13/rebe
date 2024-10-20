﻿using Domain.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class Appointment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateRange AppointmentDateRange { get; set; }  // Usando DateRange para fechas de la cita

    [Required]
    public int PatientId { get; set; }
    [ForeignKey("PatientId")]
    public User Patient { get; set; }

    [Required]
    public int StaffId { get; set; }
    [ForeignKey("StaffId")]
    public Staff Staff { get; set; }

    [Required]
    public int SpecialtyId { get; set; }
    [ForeignKey("SpecialtyId")]
    public Specialty Specialty { get; set; }

    [Required]
    public int ScheduleId { get; set; }
    [ForeignKey("ScheduleId")]
    public Schedule Schedule { get; set; }

    [Required]
    public int StateId { get; set; }
    [ForeignKey("StateId")]
    public State State { get; set; }

    [MaxLength(255)]
    public string Reason { get; set; }

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}