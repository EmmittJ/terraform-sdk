using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for test_case_conversation_turns in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for test_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxTestCaseTestConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Flow name to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    [TerraformProperty("flow")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Flow { get; set; }

    /// <summary>
    /// The page to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    [TerraformProperty("page")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Page { get; set; }

    /// <summary>
    /// Session parameters to be compared when calculating differences.
    /// </summary>
    [TerraformProperty("tracking_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TrackingParameters { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxTestCaseTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_test_case resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxTestCase : TerraformResource
{
    public GoogleDialogflowCxTestCase(string name) : base("google_dialogflow_cx_test_case", name)
    {
    }

    /// <summary>
    /// The human-readable name of the test case, unique within the agent. Limit of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Additional freeform notes about the test case. Limit of 400 characters.
    /// </summary>
    [TerraformProperty("notes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// The agent to create the test case for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Tags are short descriptions that users may apply to test cases for organizational and filtering purposes.
    /// Each tag should start with &amp;quot;#&amp;quot; and has a limit of 30 characters
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Tags { get; set; }

    /// <summary>
    /// Block for test_case_conversation_turns.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("test_case_conversation_turns")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock>>? TestCaseConversationTurns { get; set; }

    /// <summary>
    /// Block for test_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestConfig block(s) allowed")]
    [TerraformProperty("test_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxTestCaseTestConfigBlock>>? TestConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDialogflowCxTestCaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// When the test was created. A timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The latest test result.
    /// </summary>
    [TerraformProperty("last_test_result")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LastTestResult { get; }

    /// <summary>
    /// The unique identifier of the test case.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/testCases/&amp;lt;TestCase ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
