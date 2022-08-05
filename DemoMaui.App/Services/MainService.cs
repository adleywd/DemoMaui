using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMaui.App.Model;

namespace DemoMaui.App.Services
{
    public class MainService
    {
        private readonly List<TestModel> _testModelList = new ()
        {
            new TestModel() {Name = "Name1", LastName = "LastName1"},
            new TestModel() {Name = "Name2", LastName = "LastName2"},
            new TestModel() {Name = "Name3", LastName = "LastName3"}
    };

        public List<TestModel> GetTestList() => _testModelList;

    }
}
