using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appversion_lifecycle in .
/// Nesting mode: list
/// </summary>
public class AwsElasticBeanstalkApplicationAppversionLifecycleBlock : TerraformBlock
{
    /// <summary>
    /// The delete_source_from_s3 attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteSourceFromS3
    {
        get => GetProperty<TerraformProperty<bool>>("delete_source_from_s3");
        set => WithProperty("delete_source_from_s3", value);
    }

    /// <summary>
    /// The max_age_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeInDays
    {
        get => GetProperty<TerraformProperty<double>>("max_age_in_days");
        set => WithProperty("max_age_in_days", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCount
    {
        get => GetProperty<TerraformProperty<double>>("max_count");
        set => WithProperty("max_count", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_role");
        set => WithProperty("service_role", value);
    }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElasticBeanstalkApplication : TerraformResource
{
    public AwsElasticBeanstalkApplication(string name) : base("aws_elastic_beanstalk_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for appversion_lifecycle.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppversionLifecycle block(s) allowed")]
    public List<AwsElasticBeanstalkApplicationAppversionLifecycleBlock>? AppversionLifecycle
    {
        get => GetProperty<List<AwsElasticBeanstalkApplicationAppversionLifecycleBlock>>("appversion_lifecycle");
        set => this.WithProperty("appversion_lifecycle", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
