using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for test_case_conversation_turns in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for test_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestConfigBlock : TerraformBlock
{
    /// <summary>
    /// Flow name to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    public TerraformProperty<string>? Flow
    {
        get => GetProperty<TerraformProperty<string>>("flow");
        set => WithProperty("flow", value);
    }

    /// <summary>
    /// The page to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    public TerraformProperty<string>? Page
    {
        get => GetProperty<TerraformProperty<string>>("page");
        set => WithProperty("page", value);
    }

    /// <summary>
    /// Session parameters to be compared when calculating differences.
    /// </summary>
    public List<TerraformProperty<string>>? TrackingParameters
    {
        get => GetProperty<List<TerraformProperty<string>>>("tracking_parameters");
        set => WithProperty("tracking_parameters", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxTestCaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_cx_test_case resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxTestCase : TerraformResource
{
    public GoogleDialogflowCxTestCase(string name) : base("google_dialogflow_cx_test_case", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_time");
        this.DeclareOutput("last_test_result");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The human-readable name of the test case, unique within the agent. Limit of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Additional freeform notes about the test case. Limit of 400 characters.
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// The agent to create the test case for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Tags are short descriptions that users may apply to test cases for organizational and filtering purposes.
    /// Each tag should start with &amp;quot;#&amp;quot; and has a limit of 30 characters
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        get => GetProperty<List<TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for test_case_conversation_turns.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock>? TestCaseConversationTurns
    {
        get => GetProperty<List<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock>>("test_case_conversation_turns");
        set => this.WithProperty("test_case_conversation_turns", value);
    }

    /// <summary>
    /// Block for test_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestConfig block(s) allowed")]
    public List<GoogleDialogflowCxTestCaseTestConfigBlock>? TestConfig
    {
        get => GetProperty<List<GoogleDialogflowCxTestCaseTestConfigBlock>>("test_config");
        set => this.WithProperty("test_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxTestCaseTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxTestCaseTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// When the test was created. A timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The latest test result.
    /// </summary>
    public TerraformExpression LastTestResult => this["last_test_result"];

    /// <summary>
    /// The unique identifier of the test case.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/testCases/&amp;lt;TestCase ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
