using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBillingProjectInfoTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_billing_project_info resource.
/// </summary>
public class GoogleBillingProjectInfo : TerraformResource
{
    public GoogleBillingProjectInfo(string name) : base("google_billing_project_info", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("billing_account");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The ID of the billing account associated with the project, if
    /// any. Set to empty string to disable billing for the project.
    /// For example, &#39;&amp;quot;012345-567890-ABCDEF&amp;quot;&#39; or &#39;&amp;quot;&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformProperty<string> BillingAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_account");
        set => SetProperty("billing_account", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBillingProjectInfoTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
