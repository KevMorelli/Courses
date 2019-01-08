package com.kev.topic7;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "courses")
public class Course {

	@Id
	private int courseId;
	@Column(name = "CourseName")
	private String courseName;
	@Column(name = "AsignedTeacher")
	private int asignedTeacher;
	@Column(name = "HoursByWeek")
	private int hoursByWeek;
	@Column(name = "ScheduleTime")
	private String scheduleTime;

	public Course() {
	}

	public Course(int courseId, String courseName, int asignedTeacher, int hoursByWeek, String scheduleTime) {
		super();
		this.courseId = courseId;
		this.courseName = courseName;
		this.asignedTeacher = asignedTeacher;
		this.hoursByWeek = hoursByWeek;
		this.scheduleTime = scheduleTime;
	}

	public int getCourseId() {
		return courseId;
	}

	public void setCourseId(int courseId) {
		this.courseId = courseId;
	}

	public String getCourseName() {
		return courseName;
	}

	public void setCourseName(String courseName) {
		this.courseName = courseName;
	}

	public int getAsignedTeacher() {
		return asignedTeacher;
	}

	public void setAsignedTeacher(int asignedTeacher) {
		this.asignedTeacher = asignedTeacher;
	}

	public int getHoursByWeek() {
		return hoursByWeek;
	}

	public void setHoursByWeek(int hoursByWeek) {
		this.hoursByWeek = hoursByWeek;
	}

	public String getScheduleTime() {
		return scheduleTime;
	}

	public void setScheduleTime(String scheduleTime) {
		this.scheduleTime = scheduleTime;
	}

}
