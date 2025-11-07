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
        this.DeclareOutput("created_at");
        this.DeclareOutput("expires_at");
        this.DeclareOutput("id");
        this.DeclareOutput("key");
        this.DeclareOutput("service_account_token_id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public TerraformProperty<double>? SecondsToLive
    {
        get => GetProperty<TerraformProperty<double>>("seconds_to_live");
        set => this.WithProperty("seconds_to_live", value);
    }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        get => GetProperty<TerraformProperty<string>>("service_account_id");
        set => this.WithProperty("service_account_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
