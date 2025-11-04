using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_access resource.
/// </summary>
public class AwsRedshiftEndpointAccess : TerraformResource
{
    public AwsRedshiftEndpointAccess(string name) : base("aws_redshift_endpoint_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("port");
        this.DeclareOutput("vpc_endpoint");
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    public string? EndpointName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_name")?.Value;
        set => this.WithProperty("endpoint_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_owner attribute.
    /// </summary>
    public string? ResourceOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner")?.Value;
        set => this.WithProperty("resource_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public string? SubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_group_name")?.Value;
        set => this.WithProperty("subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The vpc_endpoint attribute.
    /// </summary>
    public TerraformExpression VpcEndpoint => this["vpc_endpoint"];

}
