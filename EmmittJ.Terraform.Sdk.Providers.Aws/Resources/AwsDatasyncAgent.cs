using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_agent resource.
/// </summary>
public class AwsDatasyncAgent : TerraformResource
{
    public AwsDatasyncAgent(string name) : base("aws_datasync_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public string? ActivationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("activation_key")?.Value;
        set => this.WithProperty("activation_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_address attribute.
    /// </summary>
    public string? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address")?.Value;
        set => this.WithProperty("ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The private_link_endpoint attribute.
    /// </summary>
    public string? PrivateLinkEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_endpoint")?.Value;
        set => this.WithProperty("private_link_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_arns")?.Value;
        set => this.WithProperty("security_group_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    public HashSet<string>? SubnetArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_arns")?.Value;
        set => this.WithProperty("subnet_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
