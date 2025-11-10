using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace_service_account_token resource.
/// </summary>
public class AwsGrafanaWorkspaceServiceAccountToken : TerraformResource
{
    public AwsGrafanaWorkspaceServiceAccountToken(string name) : base("aws_grafana_workspace_service_account_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("expires_at");
        SetOutput("id");
        SetOutput("key");
        SetOutput("service_account_token_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("seconds_to_live");
        SetOutput("service_account_id");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The seconds_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondsToLive is required")]
    public required TerraformProperty<double> SecondsToLive
    {
        get => GetRequiredOutput<TerraformProperty<double>>("seconds_to_live");
        set => SetProperty("seconds_to_live", value);
    }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    public required TerraformProperty<string> ServiceAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account_id");
        set => SetProperty("service_account_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    public TerraformExpression ExpiresAt => this["expires_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformExpression Key => this["key"];

    /// <summary>
    /// The service_account_token_id attribute.
    /// </summary>
    public TerraformExpression ServiceAccountTokenId => this["service_account_token_id"];

}
