using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_binary_authorization_policy resource.
/// </summary>
public class GoogleBinaryAuthorizationPolicy : TerraformResource
{
    public GoogleBinaryAuthorizationPolicy(string name) : base("google_binary_authorization_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A descriptive comment.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy. Possible values: [&amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? GlobalPolicyEvaluationMode
    {
        get => GetProperty<TerraformProperty<string>>("global_policy_evaluation_mode");
        set => this.WithProperty("global_policy_evaluation_mode", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
