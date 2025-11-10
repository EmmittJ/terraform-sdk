using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCrossAccountAttachmentResourceBlock : TerraformBlock
{
    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? CidrBlock
    {
        set => SetProperty("cidr_block", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointId
    {
        set => SetProperty("endpoint_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
    }

}

/// <summary>
/// Manages a aws_globalaccelerator_cross_account_attachment resource.
/// </summary>
public class AwsGlobalacceleratorCrossAccountAttachment : TerraformResource
{
    public AwsGlobalacceleratorCrossAccountAttachment(string name) : base("aws_globalaccelerator_cross_account_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_time");
        SetOutput("id");
        SetOutput("last_modified_time");
        SetOutput("tags_all");
        SetOutput("name");
        SetOutput("principals");
        SetOutput("tags");
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
    /// The principals attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Principals
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("principals");
        set => SetProperty("principals", value);
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
    /// Block for resource.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGlobalacceleratorCrossAccountAttachmentResourceBlock>? Resource
    {
        set => SetProperty("resource", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
