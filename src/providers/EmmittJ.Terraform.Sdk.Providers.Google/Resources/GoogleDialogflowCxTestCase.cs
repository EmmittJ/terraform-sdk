using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for test_case_conversation_turns in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock
{
}

/// <summary>
/// Block type for test_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestConfigBlock
{
    /// <summary>
    /// Flow name to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    [TerraformPropertyName("flow")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Flow { get; set; }

    /// <summary>
    /// The page to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    [TerraformPropertyName("page")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Page { get; set; }

    /// <summary>
    /// Session parameters to be compared when calculating differences.
    /// </summary>
    [TerraformPropertyName("tracking_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TrackingParameters { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxTestCaseTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_test_case resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxTestCase : TerraformResource
{
    public GoogleDialogflowCxTestCase(string name) : base("google_dialogflow_cx_test_case", name)
    {
    }

    /// <summary>
    /// The human-readable name of the test case, unique within the agent. Limit of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Additional freeform notes about the test case. Limit of 400 characters.
    /// </summary>
    [TerraformPropertyName("notes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// The agent to create the test case for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Tags are short descriptions that users may apply to test cases for organizational and filtering purposes.
    /// Each tag should start with &amp;quot;#&amp;quot; and has a limit of 30 characters
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Tags { get; set; }

    /// <summary>
    /// Block for test_case_conversation_turns.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("test_case_conversation_turns")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock>>? TestCaseConversationTurns { get; set; }

    /// <summary>
    /// Block for test_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestConfig block(s) allowed")]
    [TerraformPropertyName("test_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxTestCaseTestConfigBlock>>? TestConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxTestCaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// When the test was created. A timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The latest test result.
    /// </summary>
    [TerraformPropertyName("last_test_result")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LastTestResult => new TerraformReference(this, "last_test_result");

    /// <summary>
    /// The unique identifier of the test case.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/testCases/&amp;lt;TestCase ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
