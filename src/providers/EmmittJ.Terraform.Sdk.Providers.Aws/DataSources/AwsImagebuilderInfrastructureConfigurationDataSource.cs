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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string> ResourceTags
    {
        get => GetArgument<TerraformMap<string>>("resource_tags") ?? AsReference("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => AsReference("date_created");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformValue<string> DateUpdated
        => AsReference("date_updated");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMetadataOptions
        => AsReference("instance_metadata_options");

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    public TerraformValue<string> InstanceProfileName
        => AsReference("instance_profile_name");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformSet<string> InstanceTypes
        => AsReference("instance_types");

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformValue<string> KeyPair
        => AsReference("key_pair");

    /// <summary>
    /// The logging attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logging
        => AsReference("logging");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Placement
        => AsReference("placement");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
        => AsReference("sns_topic_arn");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformValue<bool> TerminateInstanceOnFailure
        => AsReference("terminate_instance_on_failure");

}
