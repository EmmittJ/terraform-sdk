using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_tool resource.
/// </summary>
public class GoogleDialogflowCxTool : TerraformResource
{
    public GoogleDialogflowCxTool(string name) : base("google_dialogflow_cx_tool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("tool_type");
    }

    /// <summary>
    /// High level description of the Tool and its usage.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The human-readable name of the tool, unique within the agent.
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
    /// The agent to create a Tool for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique identifier of the Tool.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/tools/&amp;lt;Tool ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The tool type.
    /// </summary>
    public TerraformExpression ToolType => this["tool_type"];

}
