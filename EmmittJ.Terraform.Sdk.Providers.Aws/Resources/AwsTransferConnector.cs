using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_connector resource.
/// </summary>
public class AwsTransferConnector : TerraformResource
{
    public AwsTransferConnector(string name) : base("aws_transfer_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("connector_id");
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    public string? AccessRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_role")?.Value;
        set => this.WithProperty("access_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public string? LoggingRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_role")?.Value;
        set => this.WithProperty("logging_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public string? SecurityPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_policy_name")?.Value;
        set => this.WithProperty("security_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public string? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url")?.Value;
        set => this.WithProperty("url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    public TerraformExpression ConnectorId => this["connector_id"];

}
