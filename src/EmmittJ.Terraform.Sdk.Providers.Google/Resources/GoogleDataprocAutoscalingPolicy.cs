using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataproc_autoscaling_policy resource.
/// </summary>
public class GoogleDataprocAutoscalingPolicy : TerraformResource
{
    public GoogleDataprocAutoscalingPolicy(string name) : base("google_dataproc_autoscaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
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
    /// The  location where the autoscaling policy should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 50 characters.
    /// </summary>
    public TerraformProperty<string>? PolicyId
    {
        get => GetProperty<TerraformProperty<string>>("policy_id");
        set => this.WithProperty("policy_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The &amp;quot;resource name&amp;quot; of the autoscaling policy.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
