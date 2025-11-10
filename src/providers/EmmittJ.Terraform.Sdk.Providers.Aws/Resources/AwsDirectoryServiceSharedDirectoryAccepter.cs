using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a aws_directory_service_shared_directory_accepter resource.
/// </summary>
public class AwsDirectoryServiceSharedDirectoryAccepter : TerraformResource
{
    public AwsDirectoryServiceSharedDirectoryAccepter(string name) : base("aws_directory_service_shared_directory_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("method");
        SetOutput("notes");
        SetOutput("owner_account_id");
        SetOutput("owner_directory_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("shared_directory_id");
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
    /// The shared_directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedDirectoryId is required")]
    public required TerraformProperty<string> SharedDirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_directory_id");
        set => SetProperty("shared_directory_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformExpression Method => this["method"];

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformExpression Notes => this["notes"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The owner_directory_id attribute.
    /// </summary>
    public TerraformExpression OwnerDirectoryId => this["owner_directory_id"];

}
