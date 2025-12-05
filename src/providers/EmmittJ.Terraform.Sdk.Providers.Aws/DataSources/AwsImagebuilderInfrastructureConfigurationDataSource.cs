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
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string> ResourceTags
    {
        get => GetArgument<TerraformMap<string>>("resource_tags") ?? CreateReference("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => CreateReference("date_created");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformValue<string> DateUpdated
        => CreateReference("date_updated");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMetadataOptions
        => CreateReference("instance_metadata_options");

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    public TerraformValue<string> InstanceProfileName
        => CreateReference("instance_profile_name");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformSet<string> InstanceTypes
        => CreateReference("instance_types");

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformValue<string> KeyPair
        => CreateReference("key_pair");

    /// <summary>
    /// The logging attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logging
        => CreateReference("logging");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Placement
        => CreateReference("placement");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => CreateReference("security_group_ids");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
        => CreateReference("sns_topic_arn");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformValue<bool> TerminateInstanceOnFailure
        => CreateReference("terminate_instance_on_failure");

}
