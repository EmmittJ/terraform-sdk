using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a aws_servicecatalog_tag_option_resource_association resource.
/// </summary>
public class AwsServicecatalogTagOptionResourceAssociation : TerraformResource
{
    public AwsServicecatalogTagOptionResourceAssociation(string name) : base("aws_servicecatalog_tag_option_resource_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("resource_arn");
        SetOutput("resource_created_time");
        SetOutput("resource_description");
        SetOutput("resource_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_id");
        SetOutput("tag_option_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The tag_option_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagOptionId is required")]
    public required TerraformProperty<string> TagOptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tag_option_id");
        set => SetProperty("tag_option_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

    /// <summary>
    /// The resource_created_time attribute.
    /// </summary>
    public TerraformExpression ResourceCreatedTime => this["resource_created_time"];

    /// <summary>
    /// The resource_description attribute.
    /// </summary>
    public TerraformExpression ResourceDescription => this["resource_description"];

    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    public TerraformExpression ResourceName => this["resource_name"];

}
