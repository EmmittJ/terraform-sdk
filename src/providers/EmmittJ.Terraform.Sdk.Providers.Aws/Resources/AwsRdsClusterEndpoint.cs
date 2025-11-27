using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_cluster_endpoint Terraform resource.
/// Manages a aws_rds_cluster_endpoint resource.
/// </summary>
public partial class AwsRdsClusterEndpoint(string name) : TerraformResource("aws_rds_cluster_endpoint", name)
{
    /// <summary>
    /// The cluster_endpoint_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterEndpointIdentifier is required")]
    public required TerraformValue<string> ClusterEndpointIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_endpoint_identifier");
        set => SetArgument("cluster_endpoint_identifier", value);
    }

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
    /// The custom_endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomEndpointType is required")]
    public required TerraformValue<string> CustomEndpointType
    {
        get => new TerraformReference<string>(this, "custom_endpoint_type");
        set => SetArgument("custom_endpoint_type", value);
    }

    /// <summary>
    /// The excluded_members attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_members").ResolveNodes(ctx));
        set => SetArgument("excluded_members", value);
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
    /// The static_members attribute.
    /// </summary>
    public TerraformSet<string>? StaticMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "static_members").ResolveNodes(ctx));
        set => SetArgument("static_members", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

}
