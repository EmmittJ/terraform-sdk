using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_endpoint_access Terraform resource.
/// Manages a aws_redshift_endpoint_access resource.
/// </summary>
public partial class AwsRedshiftEndpointAccess(string name) : TerraformResource("aws_redshift_endpoint_access", name)
{
    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    public required TerraformValue<string> EndpointName
    {
        get => new TerraformReference<string>(this, "endpoint_name");
        set => SetArgument("endpoint_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
    {
        get => new TerraformReference<string>(this, "resource_owner");
        set => SetArgument("resource_owner", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetGroupName is required")]
    public required TerraformValue<string> SubnetGroupName
    {
        get => new TerraformReference<string>(this, "subnet_group_name");
        set => SetArgument("subnet_group_name", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => new TerraformReference<string>(this, "address");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The vpc_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcEndpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_endpoint").ResolveNodes(ctx));
    }

}
