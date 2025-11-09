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
    public TerraformProperty<string>? AccessRole
    {
        get => GetProperty<TerraformProperty<string>>("access_role");
        set => this.WithProperty("access_role", value);
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
    /// The logging_role attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingRole
    {
        get => GetProperty<TerraformProperty<string>>("logging_role");
        set => this.WithProperty("logging_role", value);
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
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("security_policy_name");
        set => this.WithProperty("security_policy_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
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
