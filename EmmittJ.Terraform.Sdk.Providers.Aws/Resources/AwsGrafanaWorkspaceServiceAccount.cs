using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace_service_account resource.
/// </summary>
public class AwsGrafanaWorkspaceServiceAccount : TerraformResource
{
    public AwsGrafanaWorkspaceServiceAccount(string name) : base("aws_grafana_workspace_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("service_account_id");
    }

    /// <summary>
    /// The grafana_role attribute.
    /// </summary>
    public string? GrafanaRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grafana_role")?.Value;
        set => this.WithProperty("grafana_role", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    public TerraformExpression ServiceAccountId => this["service_account_id"];

}
