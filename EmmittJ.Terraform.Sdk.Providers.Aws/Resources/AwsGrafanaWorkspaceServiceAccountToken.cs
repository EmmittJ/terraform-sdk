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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The seconds_to_live attribute.
    /// </summary>
    public double? SecondsToLive
    {
        get => GetProperty<TerraformLiteralProperty<double>>("seconds_to_live")?.Value;
        set => this.WithProperty("seconds_to_live", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    public string? ServiceAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_id")?.Value;
        set => this.WithProperty("service_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
