using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInspector2EnablerTimeoutsBlock : TerraformBlock
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
/// Manages a aws_inspector2_enabler resource.
/// </summary>
public class AwsInspector2Enabler : TerraformResource
{
    public AwsInspector2Enabler(string name) : base("aws_inspector2_enabler", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_ids");
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_types");
    }

    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountIds is required")]
    public HashSet<TerraformProperty<string>> AccountIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("account_ids");
        set => SetProperty("account_ids", value);
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
    /// The resource_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public HashSet<TerraformProperty<string>> ResourceTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("resource_types");
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInspector2EnablerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
