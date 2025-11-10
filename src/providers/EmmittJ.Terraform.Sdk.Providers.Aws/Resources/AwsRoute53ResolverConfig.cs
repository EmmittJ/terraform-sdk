using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_config resource.
/// </summary>
public class AwsRoute53ResolverConfig : TerraformResource
{
    public AwsRoute53ResolverConfig(string name) : base("aws_route53_resolver_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("owner_id");
        SetOutput("autodefined_reverse_flag");
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_id");
    }

    /// <summary>
    /// The autodefined_reverse_flag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutodefinedReverseFlag is required")]
    public required TerraformProperty<string> AutodefinedReverseFlag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autodefined_reverse_flag");
        set => SetProperty("autodefined_reverse_flag", value);
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
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
