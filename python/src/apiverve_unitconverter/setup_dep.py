from setuptools import setup, find_packages

setup(
    name='apiverve_unitconverter',
    version='1.2.3',
    packages=find_packages(),
    include_package_data=True,
    install_requires=[
        'requests',
        'setuptools'
    ],
    description='Unit Converter converts values between different units of measurement. Pass a numeric value with source and target unit identifiers to get the converted result and unit abbreviations.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/unitconverter?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)
