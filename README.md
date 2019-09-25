# Requirements

* Read the number of employees N;
* Use a few arrays of length N to store employee names, their current salaries,and their ratings obtained for each quarter-Q1, Q2, Q3, and Q4 (ratingsrangingfrom 1-10);
* Read  a  list  of  N employee names,current  salaries,and quarterly ratings,and  store  them  in  the corresponding arrays;
* Calculate the overall (i.e., average) rating for each employee for the year (total rating/4);
* Calculate the expected salary for the next year based on the overall performance;

        increase in salary next year= current salary *(overallrating/100)

        Expected salary = current salary + amount increased
* Keep track of the employee’sperformancebased on thethree conditions:

        If the employee’soverall rating is greater than or equal to 7then the performance is tagged “BEST”.
        If the employee’soverall rating is greater than or equalto 5 and less than 7then the performance is tagged “AVERAGE”.
        If the employee’soverall rating is less than 5, then the performance is tagged “ON-TRACK”.

* Sort the recordsbased on the overall ratingin the descending order, starting with the best performance to the on-track performance; and,

* Print  all  the  employee  names,  the  ratings obtained  from  Q1  through  Q4,  the  overall  ratings,  and the performance indicators in a tabular format.
