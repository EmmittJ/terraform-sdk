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
        SetOutput("arn");
        SetOutput("certificate");
        SetOutput("domain");
        SetOutput("endpoint");
        SetOutput("endpoint_type");
        SetOutput("identity_provider_type");
        SetOutput("invocation_role");
        SetOutput("logging_role");
        SetOutput("protocols");
        SetOutput("security_policy_name");
        SetOutput("structured_log_destinations");
        SetOutput("url");
        SetOutput("id");
        SetOutput("region");
        SetOutput("server_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
