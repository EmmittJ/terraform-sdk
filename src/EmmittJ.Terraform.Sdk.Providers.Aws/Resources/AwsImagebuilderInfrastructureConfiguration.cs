using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_imagebuilder_infrastructure_configuration resource.
/// </summary>
public class AwsImagebuilderInfrastructureConfiguration : TerraformResource
{
    public AwsImagebuilderInfrastructureConfiguration(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("date_updated");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The instance_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceProfileName
    {
        get => GetProperty<TerraformProperty<string>>("instance_profile_name");
        set => this.WithProperty("instance_profile_name", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? InstanceTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("instance_types");
        set => this.WithProperty("instance_types", value);
    }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformProperty<string>? KeyPair
    {
        get => GetProperty<TerraformProperty<string>>("key_pair");
        set => this.WithProperty("key_pair", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? ResourceTags
    {
        get => GetProperty<TerraformMapProperty<string>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SnsTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("sns_topic_arn");
        set => this.WithProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateInstanceOnFailure
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_instance_on_failure");
        set => this.WithProperty("terminate_instance_on_failure", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformExpression DateUpdated => this["date_updated"];

}
