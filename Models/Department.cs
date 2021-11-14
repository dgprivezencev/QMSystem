namespace QMSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int HeadOfDepartmentId { get; set; }
        public Employee HeadOfDepartment { get; set; }
        public int HeadOfDepartnemtPostId { get; set; }
        public Post HeadOfDepartmentPost { get; set; }
        public int SuperDepartmentId { get; set; }
        public Department SuperDepartment { get; set; }
    }
}
