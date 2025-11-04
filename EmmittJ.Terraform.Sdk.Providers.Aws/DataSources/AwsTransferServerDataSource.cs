using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_transfer_server.
/// </summary>
public class AwsTransferServerDataSource : TerraformDataSource
{
    public AwsTransferServerDataSource(string name) : base("aws_transfer_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate");
        this.DeclareOutput("domain");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("endpoint_type");
        this.DeclareOutput("identity_provider_type");
        this.DeclareOutput("invocation_role");
        this.DeclareOutput("logging_role");
        this.DeclareOutput("protocols");
        this.DeclareOutput("security_policy_name");
        this.DeclareOutput("structured_log_destinations");
        this.DeclareOutput("url");
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
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformExpression EndpointType => this["endpoint_type"];

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformExpression IdentityProviderType => this["identity_provider_type"];

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformExpression InvocationRole => this["invocation_role"];

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformExpression LoggingRole => this["logging_role"];

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformExpression Protocols => this["protocols"];

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformExpression SecurityPolicyName => this["security_policy_name"];

    /// <summary>
    /// The structured_log_destinations attribute.
    /// </summary>
    public TerraformExpression StructuredLogDestinations => this["structured_log_destinations"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
