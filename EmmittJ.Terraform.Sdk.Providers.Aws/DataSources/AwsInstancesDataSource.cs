using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_instances.
/// </summary>
public class AwsInstancesDataSource : TerraformDataSource
{
    public AwsInstancesDataSource(string name) : base("aws_instances", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ids");
        this.DeclareOutput("ipv6_addresses");
        this.DeclareOutput("private_ips");
        this.DeclareOutput("public_ips");
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
    /// The instance_state_names attribute.
    /// </summary>
    public HashSet<string>? InstanceStateNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("instance_state_names")?.Value;
        set => this.WithProperty("instance_state_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public Dictionary<string, string>? InstanceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("instance_tags")?.Value;
        set => this.WithProperty("instance_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformExpression Ipv6Addresses => this["ipv6_addresses"];

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformExpression PrivateIps => this["private_ips"];

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public TerraformExpression PublicIps => this["public_ips"];

}
