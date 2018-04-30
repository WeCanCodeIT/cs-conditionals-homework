using NUnit.Framework;

namespace ConditionalsHomework
{
    [TestFixture]
    public class ConditionalsTests
    {
        private object __FILL_ME_IN__ = null;
        [Test]
        public void Code_Inside_An_If_Only_Runs_When_Condition_Is_True()
        {
            // Change the line below to make the test pass.
            var someBool = true;

            if (someBool)
            {
                Assert.Fail("Made it inside the if statement!");
            }
        }

        [Test]
        public void Code_Inside_An_Else_Only_Runs_When_Prior_Conditions_Are_False()
        {
            // Change the line below to make the test pass.
            var someBool = false;

            if (someBool)
            {
                Assert.Pass("Came inside the if statement.");
            } else
            {
                Assert.Fail("Made it inside the else statement!");
            }
        }

        [Test]
        public void Code_Inside_An_ElseIf_Only_Runs_When_Prior_Conditions_Are_False_And_Current_Condition_Is_True()
        {
            // Change the bool declarations below to make the test pass.
            var boolA = true;
            var boolB = true;

            if (boolA)
            {
                Assert.Fail("Made it inside the if statement!");
            }
            else if (boolB)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void Code_Inside_An_Else_Only_Runs_When_All_Prior_Conditions_Are_False()
        {
            // Change the bool declarations below to make the test pass.
            var boolA = true;
            var boolB = true;

            if (boolA)
            {
                Assert.Fail("Made it inside the if statement!");
            }
            else if (boolB)
            {
                Assert.Fail("Made it inside the else if statement!");
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]
        public void Only_One_Path_Is_Used_With_If_ElseIf_Else_Block()
        {
            int pathsTaken = 0;
            if (true)
            {
                pathsTaken++;
            } else if (true)
            {
                pathsTaken++;
            } else
            {
                pathsTaken++;
            }

            Assert.That(pathsTaken, Is.EqualTo(__FILL_ME_IN__));
        }

        [Test]
        public void Multiple_If_Blocks_Are_Evaluated_Independently()
        {
            int pathsTaken = 0;

            if (true)
            {
                pathsTaken++;
            }
            if (true)
            {
                pathsTaken++;
            }

            Assert.That(pathsTaken, Is.EqualTo(__FILL_ME_IN__));
        }

        [Test]
        public void Switch_Statements()
        {
            // Change the next line to make the test pass.
            var x = "Quux";

            switch (x)
            {
                case "Bar":
                    Assert.Fail("The Bar case should not run");
                    break;
                case "Foo":
                    Assert.Pass();
                    break;
                default:
                    Assert.Fail("The default case runs when no specific cases match");
                    break;
            }
        }

        [Test]
        public void Switch_Statements_Run_Default_Case_When_Nothing_Matches()
        {
            // Change the next line to make the test pass.
            var x = "Foo";

            switch (x)
            {
                case "Bar":
                    Assert.Fail("The Bar case should not run");
                    break;
                case "Foo":
                    Assert.Fail("The default case runs when no specific cases match");
                    break;
                default:
                    Assert.Pass();
                    break;
            }
        }
    }
}
