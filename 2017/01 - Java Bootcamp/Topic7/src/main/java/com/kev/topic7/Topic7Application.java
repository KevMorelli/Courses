package com.kev.topic7;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Topic7Application {

	public static void main(String[] args) {// throws SQLException {
		SpringApplication.run(Topic7Application.class, args);
		/*
		SimpleDriverDataSource dataSource = new SimpleDriverDataSource();
		dataSource.setDriver(new com.mysql.jdbc.Driver());
		dataSource.setUrl("jdbc:mysql://localhost/highschool");
		dataSource.setUsername("root");
		dataSource.setPassword("carlitos1");

		JdbcTemplate jdbcTemplate = new JdbcTemplate(dataSource);

		String sqlSelect = "SELECT * FROM courses";
		List<Course> courses = jdbcTemplate.query(sqlSelect, new RowMapper<Course>() {

			public Course mapRow(ResultSet result, int rowNum) throws SQLException {
				Course course = new Course();
				course.setCourseId(result.getInt("CourseId"));
				course.setCourseName(result.getString("CourseName"));
				course.setAsignedTeacher(result.getInt("AsignedTeacher"));
				course.setHoursByWeek(result.getInt("HoursByWeek"));
				course.setScheduleTime(result.getString("ScheduleTime"));

				return course;
			}
		});
		
		for (Course course : courses) {
            System.out.println(course.getCourseName());
        }*/
	}
}
