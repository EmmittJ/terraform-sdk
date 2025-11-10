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
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => WithProperty("cidr_block", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_id");
        set => WithProperty("endpoint_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
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
        this.WithOutput("arn");
        this.WithOutput("created_time");
        this.WithOutput("id");
        this.WithOutput("last_modified_time");
        this.WithOutput("tags_all");
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
    /// The principals attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Principals
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("principals");
        set => this.WithProperty("principals", value);
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
    /// Block for resource.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGlobalacceleratorCrossAccountAttachmentResourceBlock>? Resource
    {
        get => GetProperty<HashSet<AwsGlobalacceleratorCrossAccountAttachmentResourceBlock>>("resource");
        set => this.WithProperty("resource", value);
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
