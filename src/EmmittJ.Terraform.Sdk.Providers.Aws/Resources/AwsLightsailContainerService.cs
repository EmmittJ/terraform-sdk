using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_container_service resource.
/// </summary>
public class AwsLightsailContainerService : TerraformResource
{
    public AwsLightsailContainerService(string name) : base("aws_lightsail_container_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("created_at");
        this.DeclareOutput("power_id");
        this.DeclareOutput("principal_arn");
        this.DeclareOutput("private_domain_name");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("state");
        this.DeclareOutput("url");
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
    /// The is_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_disabled");
        set => this.WithProperty("is_disabled", value);
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
    /// The power attribute.
    /// </summary>
    public TerraformProperty<string>? Power
    {
        get => GetProperty<TerraformProperty<string>>("power");
        set => this.WithProperty("power", value);
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
    /// The scale attribute.
    /// </summary>
    public TerraformProperty<double>? Scale
    {
        get => GetProperty<TerraformProperty<double>>("scale");
        set => this.WithProperty("scale", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The power_id attribute.
    /// </summary>
    public TerraformExpression PowerId => this["power_id"];

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformExpression PrincipalArn => this["principal_arn"];

    /// <summary>
    /// The private_domain_name attribute.
    /// </summary>
    public TerraformExpression PrivateDomainName => this["private_domain_name"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
