using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_cidr_location resource.
/// </summary>
public class AwsRoute53CidrLocation : TerraformResource
{
    public AwsRoute53CidrLocation(string name) : base("aws_route53_cidr_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("cidr_blocks");
        SetOutput("cidr_collection_id");
        SetOutput("name");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlocks is required")]
    public HashSet<TerraformProperty<string>> CidrBlocks
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cidr_blocks");
        set => SetProperty("cidr_blocks", value);
    }

    /// <summary>
    /// The cidr_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrCollectionId is required")]
    public required TerraformProperty<string> CidrCollectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr_collection_id");
        set => SetProperty("cidr_collection_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
