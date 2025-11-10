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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlocks is required")]
    public HashSet<TerraformProperty<string>>? CidrBlocks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cidr_blocks");
        set => this.WithProperty("cidr_blocks", value);
    }

    /// <summary>
    /// The cidr_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrCollectionId is required")]
    public required TerraformProperty<string> CidrCollectionId
    {
        get => GetProperty<TerraformProperty<string>>("cidr_collection_id");
        set => this.WithProperty("cidr_collection_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
