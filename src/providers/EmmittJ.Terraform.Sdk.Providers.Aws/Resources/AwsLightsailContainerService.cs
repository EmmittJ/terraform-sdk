using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for private_registry_access in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServicePrivateRegistryAccessBlock : TerraformBlock
{
}

/// <summary>
/// Block type for public_domain_names in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServicePublicDomainNamesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLightsailContainerServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lightsail_container_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLightsailContainerService : TerraformResource
{
    public AwsLightsailContainerService(string name) : base("aws_lightsail_container_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zone");
        SetOutput("created_at");
        SetOutput("power_id");
        SetOutput("principal_arn");
        SetOutput("private_domain_name");
        SetOutput("resource_type");
        SetOutput("state");
        SetOutput("url");
        SetOutput("id");
        SetOutput("is_disabled");
        SetOutput("name");
        SetOutput("power");
        SetOutput("region");
        SetOutput("scale");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The is_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> IsDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_disabled");
        set => SetProperty("is_disabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The power attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Power is required")]
    public required TerraformProperty<string> Power
    {
        get => GetRequiredOutput<TerraformProperty<string>>("power");
        set => SetProperty("power", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The scale attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scale is required")]
    public required TerraformProperty<double> Scale
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scale");
        set => SetProperty("scale", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for private_registry_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccess block(s) allowed")]
    public List<AwsLightsailContainerServicePrivateRegistryAccessBlock>? PrivateRegistryAccess
    {
        set => SetProperty("private_registry_access", value);
    }

    /// <summary>
    /// Block for public_domain_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicDomainNames block(s) allowed")]
    public List<AwsLightsailContainerServicePublicDomainNamesBlock>? PublicDomainNames
    {
        set => SetProperty("public_domain_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLightsailContainerServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
