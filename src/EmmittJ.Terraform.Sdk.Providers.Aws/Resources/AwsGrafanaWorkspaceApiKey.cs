using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace_api_key resource.
/// </summary>
public class AwsGrafanaWorkspaceApiKey : TerraformResource
{
    public AwsGrafanaWorkspaceApiKey(string name) : base("aws_grafana_workspace_api_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key");
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
    /// The key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    public required TerraformProperty<string> KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
    }

    /// <summary>
    /// The key_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRole is required")]
    public required TerraformProperty<string> KeyRole
    {
        get => GetProperty<TerraformProperty<string>>("key_role");
        set => this.WithProperty("key_role", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The seconds_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondsToLive is required")]
    public required TerraformProperty<double> SecondsToLive
    {
        get => GetProperty<TerraformProperty<double>>("seconds_to_live");
        set => this.WithProperty("seconds_to_live", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformExpression Key => this["key"];

}
