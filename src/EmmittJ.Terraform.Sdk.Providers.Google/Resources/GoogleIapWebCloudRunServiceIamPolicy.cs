using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_web_cloud_run_service_iam_policy resource.
/// </summary>
public class GoogleIapWebCloudRunServiceIamPolicy : TerraformResource
{
    public GoogleIapWebCloudRunServiceIamPolicy(string name) : base("google_iap_web_cloud_run_service_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The cloud_run_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? CloudRunServiceName
    {
        get => GetProperty<TerraformProperty<string>>("cloud_run_service_name");
        set => this.WithProperty("cloud_run_service_name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
