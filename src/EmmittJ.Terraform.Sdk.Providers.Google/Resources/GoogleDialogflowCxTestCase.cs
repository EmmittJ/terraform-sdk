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
    public TerraformProperty<string>? DisplayName
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
    public TerraformProperty<List<string>>? Tags
    {
        get => GetProperty<TerraformProperty<List<string>>>("tags");
        set => this.WithProperty("tags", value);
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
