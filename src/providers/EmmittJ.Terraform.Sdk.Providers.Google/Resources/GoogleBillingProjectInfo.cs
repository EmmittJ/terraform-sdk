using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBillingProjectInfo.
/// Nesting mode: single
/// </summary>
public class GoogleBillingProjectInfoTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_billing_project_info Terraform resource.
/// Manages a google_billing_project_info resource.
/// </summary>
public partial class GoogleBillingProjectInfo(string name) : TerraformResource("google_billing_project_info", name)
{
    /// <summary>
    /// The ID of the billing account associated with the project, if
    /// any. Set to empty string to disable billing for the project.
    /// For example, &#39;&amp;quot;012345-567890-ABCDEF&amp;quot;&#39; or &#39;&amp;quot;&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformValue<string> BillingAccount
    {
        get => new TerraformReference<string>(this, "billing_account");
        set => SetArgument("billing_account", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBillingProjectInfoTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBillingProjectInfoTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
