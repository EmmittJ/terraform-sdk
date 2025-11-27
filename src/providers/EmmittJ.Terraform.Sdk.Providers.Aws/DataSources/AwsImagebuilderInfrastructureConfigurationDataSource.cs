using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_imagebuilder_infrastructure_configuration Terraform data source.
/// Retrieves information about a aws_imagebuilder_infrastructure_configuration.
/// </summary>
public partial class AwsImagebuilderInfrastructureConfigurationDataSource(string name) : TerraformDataSource("aws_imagebuilder_infrastructure_configuration", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
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
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string> ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
    {
        get => new TerraformReference<string>(this, "date_created");
    }

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformValue<string> DateUpdated
    {
        get => new TerraformReference<string>(this, "date_updated");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMetadataOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_metadata_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    public TerraformValue<string> InstanceProfileName
    {
        get => new TerraformReference<string>(this, "instance_profile_name");
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformSet<string> InstanceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "instance_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformValue<string> KeyPair
    {
        get => new TerraformReference<string>(this, "key_pair");
    }

    /// <summary>
    /// The logging attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logging
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logging").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Placement
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "placement").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
    {
        get => new TerraformReference<string>(this, "sns_topic_arn");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformValue<bool> TerminateInstanceOnFailure
    {
        get => new TerraformReference<bool>(this, "terminate_instance_on_failure");
    }

}
