using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareDicomStoreIamBindingConditionBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Manages a google_healthcare_dicom_store_iam_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleHealthcareDicomStoreIamBinding : TerraformResource
{
    public GoogleHealthcareDicomStoreIamBinding(string name) : base("google_healthcare_dicom_store_iam_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("etag");
    }

    /// <summary>
    /// The dicom_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DicomStoreId is required")]
    public required TerraformProperty<string> DicomStoreId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dicom_store_id");
        set => this.WithProperty("dicom_store_id", value);
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
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    public HashSet<TerraformProperty<string>>? Members
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public List<GoogleHealthcareDicomStoreIamBindingConditionBlock>? Condition
    {
        get => GetProperty<List<GoogleHealthcareDicomStoreIamBindingConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
