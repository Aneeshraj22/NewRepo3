Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject2/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario Outline: Successful Login with Valid Credentials
    Given User gives userid and password
       When UserClicksLogin
    Then SuccessfulLogIN message should display

    Scenario: Successful LogOut
    When User LogOut from the Application
    Then Successful LogOut message should display