using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_test_case resource.
/// </summary>
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
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Additional freeform notes about the test case. Limit of 400 characters.
    /// </summary>
    public string? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes")?.Value;
        set => this.WithProperty("notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent to create the test case for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Tags are short descriptions that users may apply to test cases for organizational and filtering purposes.
    /// Each tag should start with &amp;quot;#&amp;quot; and has a limit of 30 characters
    /// </summary>
    public List<string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
